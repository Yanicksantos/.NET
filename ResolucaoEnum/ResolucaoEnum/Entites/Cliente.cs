using System;

namespace ResolucaoEnum.Entites
{
    class Cliente
    {
        public Cliente()
        {
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }

        public Cliente(string nome, string email, DateTime aniversario)
        {
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
        }
        public override string ToString()
        {
            return "--------------------------------------------------\n"
                +"Cliente: "
                +Nome
                +" ("
                +Aniversario.ToString("dd/MM/yyyy")
                +")"
                +" - "
                +Email
                +"\n---------------------------------------------------\n"; 
        }
    }
}
