using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace todo_list_mvc.Models;

public class Todo
{
    public int Id { get; set; }

    [DisplayName("Título")]
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Title { get; set; }

    [DisplayName("Concluído")]
    public bool Done { get; set; }

    [DisplayName("Criado em")]
    public DateTime CreateAt { get; set; } = DateTime.Now;

    [DisplayName("Última atualização")]
    public DateTime LastUpdateDate { get; set; } = DateTime.Now;

    [DisplayName("Usuário")]
    public string User { get; set; }
}