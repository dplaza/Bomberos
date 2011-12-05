using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using System.ComponentModel;

namespace Bomberos.ComunFuncional.Util
{
    public static class Utilidades
    {

        #region Convertir Lista Generica a DataTable (Para Reportes)
        /// <summary>
        /// Convierte una lista generica en un DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static DataTable ConvertirListADataTable<T>(IList<T> ListaOrigen)
        {
            DataTable Tabla = CrearDataTable<T>();
            Type ListaOrigenTipoDato = typeof(T);

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(ListaOrigenTipoDato);

            foreach (T item in ListaOrigen)
            {
                DataRow Fila = Tabla.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    Fila[prop.Name] = prop.GetValue(item);
                }
                Tabla.Rows.Add(Fila);
            }
            return Tabla;
        }

        /// <summary>
        /// Crea un DataTable a partir de un tipo de dato Generico
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static DataTable CrearDataTable<T>()
        {
            Type Tipo = typeof(T);
            DataTable Tabla = new DataTable(Tipo.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(Tipo);

            foreach (PropertyDescriptor prop in properties)
            {
                Type ColumnaTipoDato = prop.PropertyType;

                if (ColumnaTipoDato.IsGenericType)
                    ColumnaTipoDato = ColumnaTipoDato.GetGenericArguments().First();

                Tabla.Columns.Add(prop.Name, ColumnaTipoDato);
            }
            return Tabla;
        }
        #endregion Convertir Lista Generica a DataTable (Para Reportes)

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
