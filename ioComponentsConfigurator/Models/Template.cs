using System.Runtime.InteropServices;

namespace ioComponentsConfigurator.Models
{
    public class Template
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<TemplateProperty> Properties { get; set; } = new List<TemplateProperty>(); 
    }

    public class TemplateProperty
    {
        public string? Name { get; set; }
        public ioInterfaceType InterfaceType {get;set;}
    }



}
