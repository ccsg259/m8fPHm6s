using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace capaLogica
{
    public class csFP
    {
        #region funciones del para serializacion del XML
            public class StringWriterEncode : StringWriter
        {
            // Añadimos un atributo que almacenara la nueva codificacion
            private Encoding encoding;
            // Creamos un nuevo constructor que permita asociar una nueva codificacion
            public StringWriterEncode(Encoding e) : base()
            {
                this.encoding = e;
            }
            // Sobrecargamos el getter que devuelve la codificacion
            public override Encoding Encoding
            {
                get
                {
                    return encoding;
                }
            }
            // Añadimos un nuevo getter que permita recuperar la codificacion por defecto
            public Encoding DefaultEncoding
            {
                get
                {
                    return base.Encoding;
                }

            }
        }
            public String ObjectToXMLGeneric<T>(T filter)
            {
                string xml = null;
                using (StringWriter sw = new  StringWriterEncode(Encoding.UTF8)) // para poner UTF8 con la funcion de Arriba "StringWriterEncode"
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    xs.Serialize(sw, filter);
                    try
                    {
                        xml = sw.ToString();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
                return xml;
            }
            public T XMLToObject<T>(string xml)
            {
                var serializer = new XmlSerializer(typeof(T));
                using (var textReader = new StringReader(xml))
                {
                    using (var xmlReader = XmlReader.Create(textReader))
                    {
                        return (T)serializer.Deserialize(xmlReader);
                    }
                }
            }
        #endregion
        #region Creacion del bloque en XML
            [Serializable] 
            public class Bloque
            {
                [XmlAttribute("IdBloque")]
                public string IdBloque { get; set; }

                [XmlAttribute("Title")]
                public string Title { get; set; }
            
                // definir los elementos para las preguntas
                [XmlArrayItem("Answer")]
                public Pregunta[] Answers {get; set;}
            }
            [Serializable] 
            public class Pregunta
            {
                [XmlAttribute("order")]
                public string order {get;set;}

                [XmlAttribute("text")]
                public string text {get;set;}

                [XmlAttribute("type")]
                public string type {get;set;}
                
                // definir los elementos de las opciones de respuestas
                [XmlArrayItem("option")]
                public Opcion[] options {get; set;}

                //[XmlElement("Barra_Botones")]
                public Barra_Botones barra_botones { get; set; }
            }
            [Serializable]
            public class Opcion
            {
                [XmlAttribute("item")]
                public string item {get; set;}
               
            }
            [Serializable]
            public class Barra_Botones
            {
                [XmlAttribute("Anterior")]
                public string Anterior { get; set; }
                
                [XmlAttribute("Siguiente")]
                public string Siguiente { get; set; }
                
                [XmlAttribute("Suspender")]
                public string Suspender { get; set; }

                [XmlAttribute("Finalizar")]
                public string Finalizar { get; set; }
                


            }

            ////////////////////////////////////////////////////////////////
            // Funcion que regresa un string XML codificado a UTF8



            public string bloqueXML(string Id_Bloque,string Nombre, ArrayList pre)
            {
                ////////////////////////////////////////////////////////////////
                Bloque bl = new Bloque();
                bl.IdBloque = Id_Bloque; //Identificador del Bloque para no perder las preguntas.
                bl.Title = Nombre;
                Pregunta[] pr = new Pregunta[pre.Count];
                ////////////////////////////////////////////////////////////////
                // creamos las preguntas
                int elementos = pre.Count;
                for (int a = 0; a < elementos; a++)
                {
                    pr[a] = new Pregunta();
                    pr[a].order =   ((object[])((pre))[a])[0].ToString();
                    pr[a].text  =   ((object[])((pre))[a])[1].ToString();
                    pr[a].type  =    ((object[])((pre))[a])[2].ToString();
                    //// opciones de la pregunta
                    string[] rop =  (string[])((object[])((pre))[a])[3];
                    Opcion[] op = new Opcion[ rop.Length ];
                    for (int c = 0; c < rop.Length; c++)
                    {
                        op[c] = new Opcion();
                        op[c].item = rop[c].ToString();
                    }
                    // Ingreso las opciones a la pregunta.
                    pr[a].options = op;
                    ////////////////////////////////////////////////////////////////
                    // se crea la barra de botones de la pregunta
                    /* Orden de las preguntas
                     * 0 - Numero de Orden de la pregunta.
                     * 1 - Texto de la pregunta.
                     * 2 - Tipo de botones de las respuestas de la pregunta.
                     * 3 - Conjunto de Opciones para elegir de la pregunta.
                     * 4 - Botones de navegacion de la pregunta, se muestran con un numero 1.Anterior 2.Siguiente 4.Suspender 8.Finalizar (se pueden sumar)
                     *  1	3	5	7	9	11	13	15
                        2	3	6	7	10	11	14	15
                        4	5	6	7	12	13	14	15
                        8	9	10	11	12	13	14	15
                     */
                    string bb = ((object[])((pre))[a])[4].ToString();
                    pr[a].barra_botones = new Barra_Botones();
                    // inciamos a cero
                    pr[a].barra_botones.Anterior = "0";
                    pr[a].barra_botones.Siguiente = "0";
                    pr[a].barra_botones.Suspender = "0";
                    pr[a].barra_botones.Finalizar = "0";   
                    if (bb == "1" || bb == "3" || bb == "5" || bb == "7" || bb == "9" || bb == "11" || bb == "13" || bb == "15")
                    {
                        pr[a].barra_botones.Anterior = "1";
                    }
                    if (bb == "2" || bb == "3" || bb == "6" || bb == "7" || bb == "10" || bb == "11" || bb == "14" || bb == "15")
                    {
                        pr[a].barra_botones.Siguiente = "1";   
                    }
                    if (bb == "4" || bb == "5" || bb == "6" || bb == "7" || bb == "12" || bb == "13" || bb == "14" || bb == "15")
                    {
                        pr[a].barra_botones.Suspender = "1";   
                    }
                    if (bb == "8" || bb == "9" || bb == "10" || bb == "11" || bb == "12" || bb == "13" || bb == "14" || bb == "15")
                    {
                        pr[a].barra_botones.Finalizar = "1";   
                    }
 

                    
                    
                    
                }

                
                ////////////////////////////////////////////////////////////////
                // ingresamos las preguntas al bloque
                bl.Answers = pr;
                ////////////////////////////////////////////////////////////////
                //crear cadena XML
                string cesar = ObjectToXMLGeneric(bl);
                return (cesar);
            }

            /* XmlSerializer objeto = new XmlSerializer(<clase>.GetType());
             * 
             * <Bloque IdBloque="cccccaaaa">
         * <poll orden="3" texto="Que Sistema Operativo usas?" tipo="1" objeto="Radio_buttom">
         *   <answer item="Windows" />
         *   <answer item="Mac OS" />
         *   <answer item="Linux" />
         *   <answer item="BeOS" />
         * </poll>
            </Bloque>
         * 
         * 
         * <poll orden="4" texto="Con que equipo cuentas?" tipo="2" objeto="check_buttom">
         *   <answer item="CPU" />
         *   <answer item="Teclado" />
         *   <answer item="Mouse" />
         *   <answer item="Laptop" />
         * </poll>
         * 
         * 
         * <poll orden="1" texto="Cuatos aa tienes" tipo="3" objeto="Caja_Texto">
         *   <answer item="Respuesta" />
         * </poll>
         * 
         * <poll orden="2" texto="Observaciones" tipo="4" objeto="campo_blob">
         *   <answer item="Respuesta" />
         * </poll>
         * 
         * 
         */

 


           
    
        #endregion

    }
}
