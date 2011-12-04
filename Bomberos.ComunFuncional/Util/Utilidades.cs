using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Bomberos.ComunFuncional.Util
{
    public static class Utilidades
    {
        #region ReflectarPropiedades

        /// <summary>
        /// Copia los valores de las propiedades desde un objeto origen a un objeto destino
        /// basandose en los nombres y tipos de datos de las propiedades
        /// </summary>
        /// <param name="objetoOrigen">The objeto origen.</param>
        /// <param name="objetoDestino">The objeto destino.</param>
        public static void ReflectarPropiedadesSimilares(object objetoOrigen, object objetoDestino)
        {
            if (objetoOrigen == null || objetoDestino == null) return;

            Type tipoOrigen = objetoOrigen.GetType();
            Type tipoDestino = objetoDestino.GetType();

            PropertyInfo[] arregloPropertyInfo = tipoOrigen.GetProperties();

            foreach (var piOrigen in arregloPropertyInfo)
            {
                try
                {
                    PropertyInfo piDestino = tipoDestino.GetProperties().Where(n => n.Name.Contains(piOrigen.Name)).First();

                    if (piDestino != null)
                    {
                        var valor = piOrigen.GetValue(objetoOrigen, null);
                        //piDestino.SetValue(objetoDestino, valor, null);
                        string asignar = valor != null ? valor.ToString() : null;
                        SeteaPropiedades(piDestino, asignar, objetoDestino);
                    }
                }
                catch (Exception ex) { }
            }

        }

        private static void SeteaPropiedades(PropertyInfo pi, string propertyValue, object instance)
        {
            try
            {
                if (
                pi.PropertyType.GetGenericArguments() != null &&
                pi.PropertyType.GetGenericArguments().Length > 0 &&
                pi.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>))
                )
                {
                    Type genericType = pi.PropertyType.GetGenericArguments()[0];
                    pi.SetValue(instance, Convert.ChangeType(propertyValue, genericType), null);
                }
                else
                {
                    pi.SetValue(instance, Convert.ChangeType(propertyValue, pi.PropertyType), null);
                }
            }

            catch (System.Exception ex) { }
        }

        #endregion ReflectarPropiedades

    }
}
