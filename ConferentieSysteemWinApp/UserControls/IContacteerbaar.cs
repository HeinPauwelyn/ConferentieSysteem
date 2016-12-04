using ConferentieSysteemData;
using System;

namespace ConferentieSysteemWinApp.UserControls
{
    public interface IContacteerbaar
    {
        string Straat { get; set; }
        string Huisnummer { get; set; }
        Gemeente Gemeente { get; set; }
        string TelefoonNr { get; set; }
        string GsmNr { get; set; }
        string Email { get; set; }
    }
}
