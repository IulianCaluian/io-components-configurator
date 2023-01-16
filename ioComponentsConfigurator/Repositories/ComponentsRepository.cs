using ioComponentsConfigurator.Models;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace ioComponentsConfigurator.Repositories
{
    public class ComponentsRepository
    {
        private static DeviceModel e1214 = new DeviceModel()
        {
            Name = "e1214",
            Specs = new List<InterfaceSpecs>()
            {
                new InterfaceSpecs() { Type = ioInterfaceType.DigitalInputChannels,  Count = 6 },
                new InterfaceSpecs() { Type = ioInterfaceType.RelayChannels,  Count = 6 }
            }
        };



        private List<Component> _componentsList  = new List<Component>()
        {
            new Component()
            {
                Id = 1,
                Name = "Bariera intrare",
                Parts = new List<ComponentPart>()
                {
                    new ComponentPart() { Name = "Senzor", Type = ioInterfaceType.DigitalInputChannels, DeviceId = 4, Index = 0}
                }
            },
            new Component()
            {
                Id = 2,
                Name = "Usa",
                Parts = new List<ComponentPart>()
                {
                    new ComponentPart() { Name = "Senzor", Type = ioInterfaceType.DigitalInputChannels, DeviceId = 4, Index = 0},
                    new ComponentPart() { Name = "Lock", Type = ioInterfaceType.RelayChannels, DeviceId = 4, Index = 0}
                }
            }
        };

        private List<Template> _templatesList = new List<Template>()
        {
            new Template()
            {
                Id = 1, 
                Name = "Bariera tip 1",
                Properties = new List<TemplateProperty>()
                {
                    new TemplateProperty() { Name = "Senzor bariera" , InterfaceType = ioInterfaceType.DigitalInputChannels }
                }
            },
            new Template()
            {
                Id = 2, 
                Name = "Usa",
                Properties = new List<TemplateProperty>()
                {
                    new TemplateProperty() { Name = "Contact" , InterfaceType = ioInterfaceType.DigitalInputChannels },
                    new TemplateProperty() { Name = "Lock" , InterfaceType = ioInterfaceType.RelayChannels }
                }
            },
            new Template() { Id = 3, Name = "Bariera tip 2" },
            new Template() { Id = 4, Name = "Poarta mecanica" }
            };



       private List<Device> HardwaresList = new List<Device>()
        {
            new Device()
        {
            Id = 1,
                Name = "Panou intrare",
                Model = e1214
            }, 
            new Device()
        {
            Id = 2,
                Name = "Panou iesire",
                Model = e1214
            }
    };

    private List<Device> _deviceList = new List<Device>()
        {
            new Device()
        {
            Id = 1,
                Name = "Panou intrare",
                Model = e1214
            }, 
            new Device()
        {
            Id = 2,
                Name = "Panou iesire",
                Model = e1214
            }
    };


    public List<Component> GetAllComponents()
        {
            return _componentsList;
        }

        public List<Template> GetAllTemplates()
        {
            return _templatesList;
        }

        public List<Device> GetAllDevices()
        {
            return _deviceList;
        }
    }
}
