using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;
using Bomberos.ComunFuncional;

namespace Bomberos.Negocio.Mgr
{
   public class LoginMgr : ILoginMgr
    {
        public bool Autentificacion(BomberoDTO p_Bombero, string tipo)
        {
            IBomberoDom _Bombero = new BomberoDom();
            BomberoDTO Bombero = new BomberoDTO();
            Bombero = _Bombero.Load(p_Bombero);

            //Se verifica la existencia del usuario.
            if (Bombero != null)
            {
                //Verificacion de username, pass y tipo de cuenta.
                if (Bombero.Password.Equals(p_Bombero.Password) && Bombero.Rut.Equals(p_Bombero.Rut) && tipo.Equals("Usuario") && !Bombero.isAdmin)
                {
                    ContextoDTO.Instancia().BomberoActual = Bombero;
                    //Es un usuario normal.
                    return true;
                }
                else
                {
                    if (Bombero.Password.Equals(p_Bombero.Password) && Bombero.Rut.Equals(p_Bombero.Rut) && tipo.Equals("Administrador") && Bombero.isAdmin)
                    {
                        ContextoDTO.Instancia().BomberoActual = Bombero;
                        //Es un administrador.
                        return true;
                    }
                    else
                    {
                        //No coincide el usuario, o la contraseña, o el tipo de cuenta.
                        return false;
                    }
                }
            }
            //La cuenta no existe en la base de datos.
            else
            {
                return false;
            }
        }
    }
}
