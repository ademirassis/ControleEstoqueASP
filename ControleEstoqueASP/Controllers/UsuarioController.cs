using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Repository;
using Microsoft.AspNetCore.Identity;
using System.Net;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace ControleEstoqueASP.Controllers
{
    //[Authorize]
    //[Authorize(Roles = "ADM")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioDAO _usuarioDAO;
        private readonly EnderecoDAO _enderecoDAO;
        private readonly UserManager<UsuarioLogado> _userManager;
        private readonly SignInManager<UsuarioLogado> _signManager;

        public UsuarioController(UsuarioDAO usuarioDAO, EnderecoDAO enderecoDAO,
            UserManager<UsuarioLogado> userManager,
            SignInManager<UsuarioLogado> signInManager)
        {
            _usuarioDAO = usuarioDAO;
            _enderecoDAO = enderecoDAO;
            _userManager = userManager;
            _signManager = signInManager;
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_usuarioDAO.ListarUsuarios());
        }

        public IActionResult Cadastrar()
        {
            String Email = User.Identity.Name;
            //Caso usuario não seja ADM não deixa Cadastrar
            if (_usuarioDAO.BuscarCargoUsuario(Email) != "Administrador")
            {
                return RedirectToAction("Index");
            }

            Usuario u = new Usuario();

            if (TempData["Endereco"] != null)
            {
                string resultado = TempData["Endereco"].ToString();
                Endereco endereco = JsonConvert.DeserializeObject<Endereco>(resultado);
                u.Endereco = endereco;
                ViewBag.perfilCargo = PerfilCargo(u);
                ViewBag.id = 1;
            }
            return View(u);
        }

        [HttpPost]
        public IActionResult BuscarCep(Usuario u)
        {
            string url = "https://api.postmon.com.br/v1/cep/" + u.Endereco.Cep;
            WebClient client = new WebClient();

            // Transport string
            TempData["Endereco"] = client.DownloadString(url);

            return RedirectToAction(nameof(Cadastrar));
        }

        // Detalhar endereco
        public IActionResult DetalheEndereco(int id)
        {
            Endereco e = _enderecoDAO.BuscarEnderecoPorId(id);

            return View(e);
        }

        //Alterar Usuario
        public IActionResult Alterar(int? id)
        {
            String Email = User.Identity.Name;
            //Caso usuario não seja ADM não deixa Alterar
            if (_usuarioDAO.BuscarCargoUsuario(Email) != "Administrador")
            {
                return RedirectToAction("Index");
            }

            Usuario u = _usuarioDAO.BuscarUsuarioPorId(id);
            ViewBag.perfilCargo = PerfilCargo(u);

            return View(u);
        }

        public IActionResult Remover(int? id)
        {
            String Email = User.Identity.Name;
            //Caso usuario não seja ADM não deixa Remover
            if (_usuarioDAO.BuscarCargoUsuario(Email) != "Administrador")
            {
                return RedirectToAction("Index");
            }

            Usuario u = _usuarioDAO.BuscarUsuarioPorId(id);
            if (u.Email != Email)
            { 
                _usuarioDAO.RemoverUsuario(u);
                return RedirectToAction("Index");
            }
            return null;
        }

        [HttpPost]
        public IActionResult Alterar(Usuario u)
        {
            if (ModelState.IsValid)
            {
                if (_usuarioDAO.AlterarUsuario(u))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Erro de atualização!");
                return View(u);
            }
            return View(u);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Usuario u)
        {
            // Criar um objeto UsuarioLogado e passar obrigatoriamente o Email e UserName
            UsuarioLogado usuarioLogado = new UsuarioLogado
            {
                Email = u.Email,
                UserName = u.Email
            };

        //Cadastra o resultado do cadastro
        IdentityResult result = await _userManager.CreateAsync(usuarioLogado, u.Senha);

            //Testar o resultado do cadastro
            if (result.Succeeded)
            {
                //Logar o usuário no sistema
                //await _signManager.SignInAsync(usuarioLogado, isPersistent: false);


                if (_usuarioDAO.CadastrarUsuario(u))
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", "Usuário já está cadastrado!");
            }
            else
            {
                AdicionarErros(result);
            }
            return View(u);
        }

        private void AdicionarErros(IdentityResult result)
        {
            foreach (var erro in result.Errors)
            {
                ModelState.AddModelError("", erro.Description);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Usuario u)
        {
            var result = await _signManager.PasswordSignInAsync(u.Email, u.Senha, true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Produto");
            }
            ModelState.AddModelError("", "Falha no Login!");
            return View();
        }

        public List<SelectListItem> PerfilCargo(Usuario u)
        {
            bool admin, gestor, operador;

            if (u.Cargo == "Administrador") { admin = true; } else { admin = false; }
            if (u.Cargo == "Gestor") { gestor = true; } else { gestor = false; }
            if (u.Cargo == "Operador") { operador = true; } else { operador = false; }

            var perfilCargoList = new List<SelectListItem>
            {
                new SelectListItem()
                {
                    Value = "Administrador",
                    Text = "Administrador",
                    Selected = admin
                },
                new SelectListItem()
                {
                    Value = "Gestor",
                    Text = "Gestor",
                    Selected = gestor
                },
                new SelectListItem()
                {
                    Value = "Operador",
                    Text = "Operador",
                    Selected = operador
                }
            };
            return perfilCargoList;
        }

        public JsonResult ValidaCpf(String cpf)
        {
            if(cpf != null)
            { 
                String msg = (_usuarioDAO.ValidaCpf(cpf)) ? "válido" : "inválido";
                return Json(msg);
            }
            return Json("");
        }
    }
}