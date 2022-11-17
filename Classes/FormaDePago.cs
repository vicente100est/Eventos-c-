namespace Classes
{
    public enum TipoAlerta
    {
        Error = 1,
        Advertencia = 2,
        Exito = 3
    }

    public enum TipoPago
    {
        Tarjeta = 1,
        Transferencia = 2,
        Otros = 3
    }

    public delegate void CambioFormaHandler(TipoPago tipoPago, TipoAlerta tipoAlerta);

    public class FormaDePago
    {
        private TipoPago _tipo;
        public event CambioFormaHandler CambioFormaPago;
        public TipoPago Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                TipoAlerta tipoAlerta = TipoAlerta.Error;

                if (value.Equals(TipoPago.Tarjeta)
                    || value.Equals(TipoPago.Transferencia)
                    || value.Equals(TipoPago.Otros))
                {
                    _tipo = value;
                    tipoAlerta = TipoAlerta.Exito;
                }

                CambioFormaPago(Tipo, tipoAlerta);
            }
        }
    }
}