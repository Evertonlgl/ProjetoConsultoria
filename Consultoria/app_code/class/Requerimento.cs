using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Requerimento
/// </summary>
public class Requerimento
{
    private int _id;
    private String _nome;
    private String _descricao;
    private int _status;
    private String _tipo;

    public int Id
    {
        get
        {
            return _id;
        }

        set
        {
            _id = value;
        }
    }

    public string Nome
    {
        get
        {
            return Nome1;
        }

        set
        {
            Nome1 = value;
        }
    }

    public string Descricao
    {
        get
        {
            return _descricao;
        }

        set
        {
            _descricao = value;
        }
    }

    public int Status
    {
        get
        {
            return _status;
        }

        set
        {
            _status = value;
        }
    }

    public string Tipo
    {
        get
        {
            return _tipo;
        }

        set
        {
            _tipo = value;
        }
    }
}

    