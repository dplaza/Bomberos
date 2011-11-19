using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class BomberoMgr : IBomberoMgr
    {
        public bool RegistroBombero(BomberoDTO p_Bombero)
        {
            IBomberoDom _Bombero = new BomberoDom();
            return _Bombero.Insert(p_Bombero);
        }

        public bool EditarBombero(BomberoDTO p_Bombero)
        {
            IBomberoDom _Bombero = new BomberoDom();
            return _Bombero.Update(p_Bombero);
        }

        public BomberoDTO CargarBombero(BomberoDTO p_Bombero)
        {
            IBomberoDom _Bombero = new BomberoDom();
            return _Bombero.Load(p_Bombero);
        }

        public List<BomberoDTO> ListarBomberos()
        {
            IBomberoDom _Bombero = new BomberoDom();
            return _Bombero.ListAll();
        }

        public string digitoVerificador(int rut)
        {
            int Digito;
            int Contador;
            int Multiplo;
            int Acumulador;
            string RutDigito;

            Contador = 2;
            Acumulador = 0;

            while (rut != 0)
            {
                Multiplo = (rut % 10) * Contador;
                Acumulador = Acumulador + Multiplo;
                rut = rut / 10;
                Contador = Contador + 1;
                if (Contador == 8)
                {
                    Contador = 2;
                }

            }

            Digito = 11 - (Acumulador % 11);
            RutDigito = Digito.ToString().Trim();
            if (Digito == 10)
            {
                RutDigito = "K";
            }
            if (Digito == 11)
            {
                RutDigito = "0";
            }
            return (RutDigito);
        }
    }
}
