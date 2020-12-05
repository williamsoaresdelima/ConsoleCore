using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador4 : iJogador
    {
        public readonly string _NomeJogador;
        public Jogador4(string nomeJogador="vaiNome")
        {
            _NomeJogador = nomeJogador;
        }
        public string Chuta()
        {
            return $"{_NomeJogador} Teste Jogador4 Chuta\n" ;
        }

        public string Corre()
        {
            return $"{_NomeJogador} Teste Jogador4 Corre\n" ;
        }

        public string Passe()
        {
            return $"{_NomeJogador} Teste Jogador4 Passe\n" ;
        }
    }
}