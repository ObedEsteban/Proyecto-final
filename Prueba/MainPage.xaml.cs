using System;
using Prueba.Clases;
using Prueba.Cosas;


namespace Prueba
{
public partial class MainPage : ContentPage
{
	int Encendido = 0;
    int Encendido2 = 0;
    int Encendido3 = 0;
    int Encendido4 = 0;
    int Encendido5 = 0;
    int velocidad = 21;
    int VelocidadActual = 21;
    int VelocidadMaxima = 130;
    int baul = 0;
    int capo = 0;

        
        private VehiculoBase Carro1;
        private PickUp one;
        private Sedan two;
        private SUV three;
        private _4x4 four;
        public MainPage()
        {

            InitializeComponent();
            Carro1 = new VehiculoBase();
            Carro1.Imagen = "\"C:\\Users\\HP\\Desktop\\Nueva carpeta\\580b585b2edbce24c47b2cd4.png\"";
            one = new PickUp();
            two = new Sedan();
            three = new SUV();
            four = new _4x4();
            propiedades();
        }
        private void propiedades()
        {
            //Propiedades Base
            Carro1.Marca = "Toyota";
            Carro1.Modelo = "Prius";
            Carro1.Color = "Negro";
            Carro1.Anio = 2004;
            Carro1.Placa = "P735SÑQ";
            Carro1.Tipo = "Mecanico";

            //Pick up
            one.Imagen = "\"C:\\Users\\HP\\Desktop\\Nueva carpeta\\580b585b2edbce24c47b2cd4.png\"";
            one.Marca = "Toyota";
            one.Modelo = "Hilux";
            one.Color = "Azul";
            one.Anio = 2021;
            one.Placa = "P844KSF";
            one.Tipo = "Automatico";
            one.Llantas = "4x4";
            one.Motor = "Electrico";
            one.Radio = "Musica: Bohemian rhapsody";
            //Sedan
            two.Marca = "Mitsubishi";
            two.Modelo = "Mirage G4";
            two.Color = "Gris";
            two.Anio = 2017;
            two.Placa = "P001SPQ";
            two.Tipo = "Mecanico";
            two.Gabinete="Trae gabinete";
            two.Sillones = "Trae 5 asientos";
            two.Aceite = "Trae aceite";
            //SUV
            three.Marca = "Skoda";
            three.Modelo = "Kamiq";
            three.Color = "Rojo";
            three.Anio = 2020;
            three.Placa = "P299YJA";
            three.Tipo = "Mecanico";
            three.Pequeño = "Es un auto pequeño";
            three.Seguro = "Es un auto seguro";
            three.Economico = "Es un auto economico";
            //4x4
            four.Marca = "Mitsubishi";
            four.Modelo = "L200";
            four.Color = "Blanco";
            four.Anio = 2019;
            four.Placa = "P901ZDM";
            four.Tipo = "Automatico";
            four.Hermoso = "Es un auto hermoso";
            four.Comodo = "Es un auto comodo";
            four.Caro = "Es un auto caro";
            //Interfaz Base
            Marca.Text = Carro1.Marca;
            Modelo.Text = Carro1.Modelo;
            Color.Text = Carro1.Color;
            Anio.Text = Carro1.Anio.ToString();
            Placa.Text = Carro1.Placa;
            Tipo.Text = Carro1.Tipo;
            //Interfaz Pick up
            Marca2.Text = one.Marca;
            Modelo2.Text = one.Modelo;
            Color2.Text = one.Color;
            Anio2.Text = one.Anio.ToString();
            Placa2.Text = one.Placa;
            Tipo2.Text = one.Tipo;
            Llantas.Text = one.Llantas;
            Motor.Text = one.Motor;
            Radio.Text = one.Radio;
            //Interfaz Sedan
            Marca3.Text = two.Marca;
            Modelo3.Text = two.Modelo;
            Color3.Text = two.Color;
            Anio3.Text = two.Anio.ToString();
            Placa3.Text = two.Placa;
            Tipo3.Text = two.Tipo;
            Gabinete.Text = two.Gabinete;
            Sillones.Text = two.Sillones;
            Aceite.Text = two.Aceite;
            //Interfaz SUV
            Marca4.Text = three.Marca;
            Modelo4.Text = three.Modelo;
            Color4.Text = three.Color;
            Anio4.Text = three.Anio.ToString();
            Placa4.Text = three.Placa;
            Tipo4.Text = three.Tipo;
            Pequeño.Text = three.Pequeño;
            Seguro.Text = three.Seguro;
            Economico.Text = three.Economico;
            //Interfaz 4x4
            Marca5.Text = four.Marca;
            Modelo5.Text = four.Modelo;
            Color5.Text = four.Color;
            Anio5.Text = four.Anio.ToString();
            Placa5.Text = four.Placa;
            Tipo5.Text = four.Tipo;
            Hermoso.Text = four.Hermoso;
            Comodo.Text = four.Comodo;
            Caro.Text = four.Caro;

            relleno.Text = "--------------------------------------------------------------------------------------------------------------------------------------------";
            relleno1.Text = "--------------------------------------------------------------------------------------------------------------------------------------------";
            relleno2.Text = "--------------------------------------------------------------------------------------------------------------------------------------------";
            relleno3.Text = "--------------------------------------------------------------------------------------------------------------------------------------------";
            relleno4.Text = "--------------------------------------------------------------------------------------------------------------------------------------------";
            relleno5.Text = "--------------------------------------------------------------------------------------------------------------------------------------------";
            relleno6.Text = "--------------------------------------------------------------------------------------------------------------------------------------------";
            relleno7.Text = "--------------------------------------------------------------------------------------------------------------------------------------------";
            relleno8.Text = "--------------------------------------------------------------------------------------------------------------------------------------------";

        }
        private void Bocinas_Clicked(object sender, EventArgs e)
        {
            Carro1.Bocina();
            if (Encendido== 1) 
            {
                Fua.Text = "Boom Boom";
            }
            else
            {
                Fua.Text = "...";
            }
        }
        private void EncenderAutomovil_Clicked(object sender, EventArgs e)
        {
            Carro1.Encender();
            if (Encendido== 0)
            { 
                Fua.Text = "El automóvil se ha encendido.";
                Encendido = 1;
            }
            else
            { Fua.Text = "El automovil ya esta encendido"; }
        }

        private void AcelerarAutomovil_Clicked(object sender, EventArgs e)
        {
            Carro1.Acelerar(21);
            Carro1.Velocidades(21,130);
            VelocidadActual += VelocidadActual;

            if (Encendido== 1&&(VelocidadActual <= VelocidadMaxima)) 
            { 
            Carro1.Acelerar(velocidad);
            Fua.Text = $"El automóvil está acelerando a {velocidad} km/h.";
            Velocidades.Text = "La velocidad maxima es de: " + VelocidadMaxima + "km/h";
            Velocidadactual.Text = "La Velocidad actual es de: " + VelocidadActual + "km/h";
            }
            else if (Encendido==1&&(VelocidadActual > VelocidadMaxima))
            {
                Velocidadactual.Text = "El auto no puede exceder la velocidad maxima";
                VelocidadActual = 130;
            }
            else
            {
                Fua.Text = "El auto esta apagado";
                Velocidadactual.Text = "El auto no puede dar las velocidades porque esta apagado";
            }
        }
        private void Apagar_Cliked(object sender, EventArgs e)
        {
            Carro1.Apagar();
            if (Encendido == 1)
            {
                Fua.Text = "El automóvil se ha apagado.";
                Encendido = 0;
            }
            else
            { Fua.Text = "El automovil ya esta apagado"; }
        }
        private void Frenar_Clicked(object sender, EventArgs e)
        {
            Carro1.Frenar(5);
            int cuanto = 5;
            VelocidadActual -= cuanto;
            if (Encendido == 1&&(VelocidadActual>0))
            {
                Fua.Text=$"freno y la velocidad bajo a: {VelocidadActual} mk/h";
                Velocidadactual.Text = "";
            }
            else
            {
                Fua.Text=$"freno y la velocidad bajo a: 0 mk/h";
                Velocidadactual.Text = "";
            }
        }
        private void Encenderpickup(object sender, EventArgs e)
        {
            one.Encender1();
            if (Encendido2 == 0)
            {
                Fua2.Text = "El Pick up se ha encendido.";
                Encendido2 = 1;
            }
            else
            { Fua2.Text = "El Pick up ya esta encendido"; }
        }
        private void Abrirventana (object sender, EventArgs e)
        {
            one.Abrirventa();
            if (Encendido2 == 1)
            {
                Fua2.Text = "Se pueden abrir las ventanas";

            }
            else
            { Fua2.Text = "No se pueden cerrar las ventanas porque el auto esta apagado"; }
        }
        private void EncenderSedan(object sender, EventArgs e)
        {
            two.Encender();
            if (Encendido3 == 0)
            {
                two.Encender();
                Fua3.Text="El sedan se ha encendido";
                Encendido3 = 1;
            }
            else
            {
                Fua3.Text="El sedan ya esta encendido";
            }
        }
        private void Abrirbaul(object sender, EventArgs e)
        {
            if (baul==0) 
            { 
            Fua3.Text="Abir baul";
            baul= 1;
            }
            else
            {
            Fua3.Text = "El baul ya esta abierto";
            }
        }
        private void Cerrarbaul(object sender, EventArgs e)
        {
            if (baul == 1)
            {
                Fua3.Text = "Cerrar baul";
                baul = 0;
            }
            else
            {
                Fua3.Text = "El baul ya esta cerrado";
            }
        }
        private void EncenderSUV(object sender, EventArgs e)
        {
            three.Encender();
            if (Encendido4 == 0)
            {
                Fua4.Text="Se ha encendido el suv";
                Encendido4 = 1;
            }
            else
            {
                Fua4.Text="El auto ya esta encendido";
            }
        }
        private void Abrircapo(object sender, EventArgs e)
        {
            if (capo == 0)
            {
                Fua4.Text = "Abrir capo";
                capo = 1;
            }
            else
            {
                Fua4.Text = "El capo ya es abierto";
            }
        }
        private void Encender4x4(object sender, EventArgs e)
        {
            four.Encender();
            if (Encendido5 == 0)
            {
                Fua5.Text="El 4x4 se ha encendido";
                Encendido5 = 1;
            }
            else
            {
                Fua5.Text = "El auto ya esta encendido";
            }
        }
        private void Luces(object sender, EventArgs e)
        {
            if (Encendido5 == 1)
            {
                Fua5.Text="Encender luces";
            }
            else
            {
                Fua5.Text="No se pueden encer las luces";
            }
        }
    }
}

