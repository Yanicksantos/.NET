using System;
using System.Collections.Generic;
using System.Text;

namespace ApredendoSobreposicao.Entites
{
    sealed class CriandoClassSelada: ContaBancaria
    {
        /*Sealed torna a class privada e sem possibilidade de ser usado por outras classes como
        class herdada. Na pratica, nenhuma class poderá existir usando ela.
        impedir que essas caracteristicas sejam apenas usadas nela. 
        MAIS SEGURANÇA E PERFORMACE. FORA A DIMUIÇAÕ DE ERROS FUTUROS*/

        public sealed override void Saque(double valor) /* Selando metodo, impede o metodo ser 
                                                         sobreposto novamente. Melhor performace.


                                                        Para um metodo ser selado, é necessario
                                                         ja ser uma sobreposicao de um metodo 
                                                        pelo menos*/
        {
            base.Saque(valor);
        }
    }
}
