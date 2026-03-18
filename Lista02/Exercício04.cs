using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

string caracteres = "QWERTYUIOPASDFGHJKLÇZXCVBNMqwertyuiopasdfghjklçzxcvbnm1234567890";

Random random = new Random();
int tamanhoSenha = 8;
string senha = "";


for (int i = 0; i < tamanhoSenha; i++)
{
    int index = random.Next(caracteres.Length);
    senha += caracteres[index];
}

Console.WriteLine($"Sua senha aleatória é:{senha}");
