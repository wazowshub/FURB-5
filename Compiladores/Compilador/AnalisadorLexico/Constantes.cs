using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisadorLexico
{
    public class Constants : ScannerConstants
    {
        int EPSILON = 0;
        int DOLLAR = 1;

        int t_identificador = 2;
        int t_constante_inteira = 3;
        int t_constante_real = 4;
        int t_constante_caracter = 5;
        int t_cmnt_bloco = 6;
        int t_cmnt_linha = 7;
        int t_algoritmo = 8;
        int t_ate = 9;
        int t_caracter = 10;
        int t_e = 11;
        int t_enquanto = 12;
        int t_entao = 13;
        int t_escreva = 14;
        int t_faca = 15;
        int t_falso = 16;
        int t_fim = 17;
        int t_funcao = 18;
        int t_inicio = 19;
        int t_inteiro = 20;
        int t_interrompa = 21;
        int t_leia = 22;
        int t_logico = 23;
        int t_nao = 24;
        int t_ou = 25;
        int t_procedimento = 26;
        int t_quebra = 27;
        int t_real = 28;
        int t_repita = 29;
        int t_retorne = 30;
        int t_se = 31;
        int t_senao = 32;
        int t_variaveis = 33;
        int t_verdadeiro = 34;
        int t_TOKEN_35 = 35; //"+"
        int t_TOKEN_36 = 36; //"-"
        int t_TOKEN_37 = 37; //"*"
        int t_TOKEN_38 = 38; //"/"
        int t_TOKEN_39 = 39; //"\"
        int t_TOKEN_40 = 40; //"%"
        int t_TOKEN_41 = 41; //"^"
        int t_TOKEN_42 = 42; //","
        int t_TOKEN_43 = 43; //":"
        int t_TOKEN_44 = 44; //";"
        int t_TOKEN_45 = 45; //"<-"
        int t_TOKEN_46 = 46; //"="
        int t_TOKEN_47 = 47; //"<>"
        int t_TOKEN_48 = 48; //"<"
        int t_TOKEN_49 = 49; //"<="
        int t_TOKEN_50 = 50; //">"
        int t_TOKEN_51 = 51; //">="
        int t_TOKEN_52 = 52; //"("
        int t_TOKEN_53 = 53; //")"

        public static Dictionary<Func<int, bool>, string> sw = new Dictionary<Func<int, bool>, string>
        {
            {x => x == 2, "Identificador"},
			{x => x == 3, "Constante inteira"},
			{x => x == 4, "Constante real"},
			{x => x == 5, "Constante caracter"},
			{x => x >= 8 && x <= 34, "Palavra reservada"},
			{x => x >= 35 && x <= 53, "Símbolo especial"}
		};

        public static string ToClassType(int id)
        {
			return sw.First(sw => sw.Key(id)).Value;
        }
    }
}
