namespace UserInformation
{
    //Desafio 3:
    //Crie uma API em C# utilizando o framework ASP.NET Core. A API deve permitir criar, ler, atualizar e excluir
    //registros de uma entidade específica (por exemplo, "Usuário"). Certifique-se de implementar as operações 
    //HTTP adequadas (GET, POST, PUT, DELETE) e retornar respostas adequadas em formato JSON.

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario { Nome = "Vinicius", Id = 1, Email = "Viniragh@gmail.com", Senha = "12345678" }
            };
  
            app.MapGet("/usuarios", () => 
            {
                return usuarios;
            });

            app.MapPost("/usuarios", (Usuario usuario) => 
            {
                usuarios.Add(usuario);
            });

            app.MapPut("/usuarios/{id:int}", (int id, Usuario usuario) =>
            {
                var usuarioAtual = usuarios.Find(user => user.Id == id);

                if(usuarioAtual == null)
                {
                    return Results.NotFound();
                }

                usuarioAtual.Nome = usuario.Nome;
                usuarioAtual.Senha = usuario.Senha;
                usuarioAtual.Email = usuario.Email;

                return Results.Ok();
            });

            app.MapDelete("/usuario/{id:int}", (int id) =>
            {
                var usuario = usuarios.Find(x => x.Id == id);

                if(usuario == null)
                {
                    return Results.NotFound();
                };

                usuarios.Remove(usuario);
                return Results.Ok(usuario);
            });

            app.Run();
        }
         class Usuario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }
        }
    }
}