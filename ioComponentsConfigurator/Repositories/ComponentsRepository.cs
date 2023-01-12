using ioComponentsConfigurator.Models;
using System.IO;
using System.Xml.Linq;

namespace ioComponentsConfigurator.Repositories
{
    public class ComponentsRepository
    {
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

        public List<Component> GetAllComponents()
        {
            return _componentsList;
        }

        public List<Template> GetAllTemplates()
        {
            return _templatesList;
        }
    }
}
