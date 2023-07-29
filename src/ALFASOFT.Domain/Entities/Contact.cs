using ALFASOFT.Domain.DomainObjects;

namespace ALFASOFT.Domain.Entities;

public class Contact : Entity, IAggregateRoot
{
    public Contact(){ }
    public Contact(string name, string contactNumber, string emailAddress)
    {
        Name = name;
        ContactNumber = contactNumber;
        EmailAddress = emailAddress;
        Validar();
    }

    public string Name { get;private set; }
    public string ContactNumber { get; private set; } 
    public string EmailAddress { get; private set; }

    private void Validar()
    {
        //Validacoes.ValidarTamanhoFixo(Name,5, "O Nome deve ter minimo 5 carateres!!");
        //Validacoes.ValidarSeTamanhoNaoForIgualAoEsperado(ContactNumber, 9, "O seu contacto é invalido");
        //Validacoes.ValidarSeEmailValido(Name, "Email inválido");
    }
}
