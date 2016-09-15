using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for comentario
/// </summary>
public class comentario
{
    private int _id;
    private String _texto;

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

    public string Texto
    {
        get
        {
            return _texto;
        }

        set
        {
            _texto = value;
        }
    }
}