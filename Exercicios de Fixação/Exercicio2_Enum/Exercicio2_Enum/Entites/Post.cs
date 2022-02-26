using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2_Enum.Entites
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> comentarios { get; set; } = new List<Comentario>();

        public Post()
        {
        }

        public Post(DateTime moment, string titulo, string conteudo, int likes)
        {
            Moment = moment;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentarios(Comentario comentario1)
        {
            comentarios.Add(comentario1);
        }
        public void RemoveComentarios(Comentario comentario1)
        {
            comentarios.Remove(comentario1);
        }

        // Tostring mais complexo
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Titulo);
            stringBuilder.Append(Likes);
            stringBuilder.Append("Likes - ");
            stringBuilder.AppendLine(Moment.ToString("dd/MM/yyy HH:mm:ss"));
            stringBuilder.AppendLine(Conteudo);
            stringBuilder.AppendLine("Comentarios: ");
            foreach (Comentario com in comentarios)
            {
                stringBuilder.AppendLine(com.Text);
            }
            return stringBuilder.ToString();
        }
    }
}
