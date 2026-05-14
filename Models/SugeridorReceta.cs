namespace TP2;
public class SugeridorReceta
{
    public string nombreReceta{get;set;};
    public datetime fechaNacimiento{get;set;};
    public string tipoComida{get;set;};
    public int presupuesto{get;set;};
    public int cantComensales{get;set;};

    
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

    public void determinarPlato()
    {
        public string platoSugerido{get;set;}


    }
}