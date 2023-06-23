using SQLite;

namespace People.Models;

[Table("parametros")]
public  class Parametros
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(200), Unique]
    public string Nombre { get; set; }
    public long Precio { get; set; }


}
