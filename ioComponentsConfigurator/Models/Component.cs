namespace ioComponentsConfigurator.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TemplateName { get; set; }
        public List<ComponentPart>? Parts { get; set; }
    }

    public class ComponentPart
    {
        public string? Name { get; set; }
        public ioInterfaceType? Type { get; set; }
        public int DeviceId { get; set; }
        public int Index { get; set; }
        
    }
}
