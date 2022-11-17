using Classes;

public class Program
{
    private static void Main(string[] args)
    {
        string tipoPago;

        Console.WriteLine("Ingresa una forma de pago: ");
        Console.WriteLine("1.- Tarjeta        2.- Transferencia\n3.- Otros");
        tipoPago = Console.ReadLine();

        FormaDePago fm = new FormaDePago();

        fm.CambioFormaPago += fm_SeleccioneFormaPago;

        fm.Tipo = (TipoPago)Enum.Parse(typeof(TipoPago), tipoPago);
    }

    public static void fm_SeleccioneFormaPago(TipoPago tipo, TipoAlerta tipoAlerta)
    {
        if(tipoAlerta.Equals(TipoAlerta.Error))
            Console.WriteLine("Error, elegiste forma de pago erronea");
        else if(tipoAlerta.Equals(TipoAlerta.Error))
            Console.WriteLine("Forma de pago seleccionada: {0} ", tipo.ToString);
    }
}