namespace tp2.Models;

public class SugeridorReceta
{
    public string nombreCocinero{get;set;}
    public DateTime fechaNacimiento{get;set;}
    public string tipoComida{get;set;}
    public int presupuesto{get;set;}
    public int cantComensales{get;set;}

    
    public int calcularEdad()
    {
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - fechaNacimiento.Year;
        if (hoy < fechaNacimiento.AddYears(edad))
    {
        edad--;
    }

    return edad;
    }

    public string determinarPlato()
    {
        string platoSugerido = "";

    if (tipoComida == "Caliente")
    {
        if (presupuesto < 3000)
        {
            platoSugerido = "fideos con manteca.";
        }
        else if (presupuesto >= 3000 && presupuesto <= 7000)
        {
            platoSugerido = "arroz con verduras salteadas.";
        }
        else
        {
            platoSugerido = "pollo al horno con guarnición.";
        }
    }
    else if (tipoComida == "Fría")
    {
        if (presupuesto < 3000)
        {
            platoSugerido = "ensalada simple.";
        }
        else if (presupuesto >= 3000 && presupuesto <= 7000)
        {
            platoSugerido = "ensalada completa con proteína.";
        }
        else
        {
            platoSugerido = "tabla de fiambres y queso.";
        }
    }

    return platoSugerido;
    }
    public int CalcularTiempo(){

        int tiempo = 0;

    if (tipoComida == "Caliente")
    {
        if (cantComensales == 1)
        {
            tiempo = 20;
        }
        else if (cantComensales >= 2 && cantComensales <= 3)
        {
            tiempo = 20;
        }
        else if (cantComensales >= 4 && cantComensales <= 7)
        {
            tiempo = 40;
        }
        else
        {
            tiempo = 80;
        }
    }
    else if (tipoComida == "Fría")
    {
        if (cantComensales >= 1 && cantComensales <= 3)
        {
            tiempo = 10;
        }
        else if (cantComensales >= 4 && cantComensales <= 7)
        {
            tiempo = 20;
        }
        else
        {
            tiempo = 40;
        }
    }

    return tiempo;

    }
    public string DeterminarDificultad()
{
    string dificultad = "";
    if (cantComensales >= 8)
    {
        dificultad = "Avanzado";
    }
    else if (presupuesto < 3000 && cantComensales >= 1 && cantComensales <= 3)
    {
        dificultad = "Principiante";
    }
    else
    {
        dificultad = "Intermedio";
    }

    return dificultad;
}
}