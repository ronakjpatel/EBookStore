using System.ComponentModel.DataAnnotations;

namespace ECommerceBookStore;
//All of the content that is inside this models classes will later be used to create the data tables in the 
// data bases. all of this hard work will be taken care by the entity framework in .net
public class Category
{
    //we need data annotation to let entity framework know that this is the primary key and this are the required 
    // fields so on 
    [Key]
    public int Id{ get; set; }
    [Required] //same as Not null in sql
    public string Name { get; set; }
    public int DisplayOrder { get; set; }

}
