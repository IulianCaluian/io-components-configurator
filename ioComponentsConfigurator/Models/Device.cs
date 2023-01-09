namespace ioComponentsConfigurator.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public DeviceModel? Model { get; set; }
    }

    public class DeviceModel
    {
        public string? Name { get; set; }
        public List<InterfaceSpecs>? Specs { get; set; }

    }

    public class InterfaceSpecs
    {
        public int Count { get; set; }
        public ioInterfaceType Type { get; set; }
    }

}
