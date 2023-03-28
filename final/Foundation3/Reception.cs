using System;
using System.Collections;

class Reception : Event
{
    protected string _emailRSVP;
    protected int _haveRSVPd;

    public Reception()
    {

    }

    public Reception(string email, int rsvp)
    {
        _emailRSVP = email;
        _haveRSVPd = rsvp;
    }
}