using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Assinatura
/// </summary>
public class Assinatura
{
    private long _cpf;
    private long _credcard;
    private Int32 _plano;

    public long Cpf
    {
        get
        {
            return _cpf;
        }

        set
        {
            _cpf = value;
        }
    }

    public long Credcard
    {
        get
        {
            return _credcard;
        }

        set
        {
            _credcard = value;
        }
    }

    public int Plano
    {
        get
        {
            return _plano;
        }

        set
        {
            _plano = value;
        }
    }
}