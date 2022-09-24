
//clase contacto
class Contacto
{
    private string nombre;
    private string telefono;
    private string email;

    public Contacto(string nombre, string telefono, string email)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.email = email;
    }
    public Contacto()
    {
        this.nombre = "";
        this.telefono = "";
        this.email = "";
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }   
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public override string ToString()
    {
        return string.Format("Nombre: {0}, Telefono: {1}, Email: {2}", nombre, telefono, email);
    }
}

