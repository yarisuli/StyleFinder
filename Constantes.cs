namespace App_Ropa___Intento_1
{
    public static class Constantes
    {
        //Situaciones
        public enum Situacion
        {
            Ninguna = 0, Deporte = 1, Salir = 2, Elegante = 3, Casual = 4
        };
        public enum TipoPrenda
        {
            Ninguna = 0, Remera = 1, Vestido = 2, Abrigo = 3, Accesorio = 4, Pantalon = 5, Pollera = 6, Calzado = 7
        };
        public enum ColorPrenda
        {
            Rojo = 0, Naranja = 1, Amarillo = 2, Verde_Claro = 3, Verde = 4, Cian = 5, Rosita = 6, Rosa = 7, Violeta_Claro = 8, Violeta = 9, Azul = 10, Celeste = 11
        };
        public enum VariantePrenda
        {
            Ninguna = 0, Abrigo_Buzo = 1, Abrigo_Blazer = 2, Abrigo_Chaqueta = 3, Abrigo_Pullover = 4, Abrigo_Campera = 5, Abrigo_Saco = 6, Remera_Musculosa = 7, Remera_Oversize = 8, Remera_Larga = 9, Remera_Elegante = 10, Remera_Corta = 11, Remera_Deportiva = 12, Remera_Top = 13, Remera_Clasica = 14, Vestido_Largo = 15, Vestido_Con_Mangas = 16, Vestido_Corto = 17, Vestido_Sin_Mangas = 18, Vestido_Casual = 19, Vestido_Formal = 20, Accesorio_Aros = 21, Accesorio_Bolso = 22, Accesorio_Collar = 23, Accesorio_Cartera = 24, Accesorio_Pulsera = 25, Accesorio_Anteojos = 26, Pantalon_Largo = 27, Pantalon_Clasico = 28, Pantalon_Elegante = 29, Pantalon_Corto = 30, Pantalon_Deportivo = 31, Pollera_Larga = 32, Pollera_Corta = 33, Pollera_Formal = 34, Pollera_Casual = 35, Calzado_Deportivo = 36, Calzado_Zapatillas = 37, Calzado_Sandalias = 38, Calzado_Formal = 39, Calzado_Botas = 40
        };       
        
        //INSERTAR SELECCIONADOS A DB

        //int imagen = Convert.ToBase64(Console.ReadLine()); 
        //int colorPrenda = BOTON QUE SE APRETE VA A DARLE VALOR A VARIABLE
        // int tipoId = BOTON QUE SE APRETE VA A DARLE VALOR A VARIABLE
        public static string InsertArticulo = "INSERT INTO articulo (imagen, color, tipo_id) VALUES (@imagen, @color, @tipoId)";
        //new OleDbParameter("@imagen", imagen);
        //new OleDbParameter("@color", colorPrenda);
        //new OleDbParameter("@tipoId", tipoId);

        //ESTE INSERT METE DESCRIPCION DE LA PRENDA A TIPO ARTICULO, DONDE ESTA SI ES ABRIGO, REMERA, ETC
        // int parteId = BOTON QUE SE APRETE VA A DARLE VALOR A VARIABLE
        public static string InsertTipoArticulo = "INSERT INTO tipo_articulo (parte_id) VALUES (@parteId)";
        //new OleDbParameter("@parteId", parteId);

        //ESTE INSERT METE A TIPO ARTICULO EN VARIABLE TIPO, SI ES PARTE DE ARRIBA, ABAJO
        // int tipoId = BOTON QUE SE APRETE VA A DARLE VALOR A VARIABLE
        public static string InsertVarianteTipo = "INSERT INTO variante_tipo (tipo_id) VALUES (@tipoId)";
        //new OleDbParameter("@tipoId", tipoId);

        //INSERT EVENTO Y CALENDARIO
        // int colorButton = BOTON QUE SE APRETE VA A DARLE VALOR A VARIABLE
        // string evento = txtBoxEvento.Txt
        // VARIABLE FECHAAAAA = ...
        public static string InsertEvento = "INSERT INTO evento (descripcion, color, fecha) VALUES (@descripcion, @color, @fecha)";
        //new OleDbParameter("@descripcion", descripcion);
        //new OleDbParameter("@color", colorButton);
        //new OleDbParameter("@fecha, fecha);

      

      
    }
}