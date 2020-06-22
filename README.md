Instalar no Patch Nuget

Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

Após as criações das classes abrir o terminal em: Exibir -> Outras Janelas -> Console do Gerenciador de Pacotes

get-help entityframeworkcore // Mostra o que é possível utilizar
Add-Migration inicial        // Cria o script que vai ser rodado e é salvo em "Inicial"
Update-Database              // Cria as Bases de dados
Script-Migration             // Cria os Script após a criação das Classes


// Exemplo de String de Conexão

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("Password=27101997;Persist Security Info=True;User ID=sa;Initial Catalog=HeroApp;Data Source=DESKTOP-48O40OQ\\CONEXAOSQL");
}
