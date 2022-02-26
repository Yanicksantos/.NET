using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2_Enum.Entites
{
    class Comentario
    {
        public Comentario()
        {
        }

        public string Text { get; set; }

        public Comentario(string text)
        {
            Text = text;
        }
    }
}
