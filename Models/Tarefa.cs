using AppMvc.Data;
namespace AppMvc.Models {
    public class Tarefa {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }    
    }
}
