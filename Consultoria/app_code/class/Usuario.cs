using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuario
/// </summary>
public class Usuario
{
    private long _cpf;
    private String _nome;
    private String _email;
    private String _password;
    private String _cidade;
    private String _URF;
    private String _bairro;
    private String _rua;
    private String _numero;
    private long _telefone;
    private long _celular;


    public long Cpf
    {
        get{return _cpf;}
        set{_cpf = value;}
    }

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
            _nome = value;
        }
    }

    public string Email
    {
        get
        {
            return _email;
        }

        set
        {
            _email = value;
        }
    }

    public string Password
    {
        get
        {
            return _password;
        }

        set
        {
            _password = value;
        }
    }

    public string Cidade
    {
        get
        {
            return _cidade;
        }

        set
        {
            _cidade = value;
        }
    }

    public string URF
    {
        get
        {
            return _URF;
        }

        set
        {
            _URF = value;
        }
    }

    public string Bairro
    {
        get
        {
            return _bairro;
        }

        set
        {
            _bairro = value;
        }
    }

    public string Rua
    {
        get
        {
            return _rua;
        }

        set
        {
            _rua = value;
        }
    }

    public string Numero
    {
        get
        {
            return _numero;
        }

        set
        {
            _numero = value;
        }
    }

    public long Telefone
    {
        get
        {
            return _telefone;
        }

        set
        {
            _telefone = value;
        }
    }

    public long Celular
    {
        get
        {
            return _celular;
        }

        set
        {
            _celular = value;
        }
    }
}