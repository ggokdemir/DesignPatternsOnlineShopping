using System;

namespace OnlineShoppingCenter
{
    public interface IAbstractFactory
    {
        IAbstractDesktopPC DesktopPC();

        IAbstractNotebookPC NotebookPC();
    }

    class GamingFactory : IAbstractFactory
    {
        public IAbstractDesktopPC DesktopPC()
        {
            return new GamingDesktop();
        }

        public IAbstractNotebookPC NotebookPC()
        {
            return new GamingNotebook();
        }
    }


    class WorkstationFactory : IAbstractFactory
    {
        public IAbstractDesktopPC DesktopPC()
        {
            return new WorkstationDesktop();
        }

        public IAbstractNotebookPC NotebookPC()
        {
            return new WorkstationNotebook();
        }
    }


    public interface IAbstractDesktopPC
    {
        string SetConfigurationsDesktopPC();
    }

    
    class GamingDesktop : IAbstractDesktopPC
    {
        public string SetConfigurationsDesktopPC()
        {
            return "Setting configuration for GamingDesktop.";
        }
    }

    class WorkstationDesktop : IAbstractDesktopPC
    {
        public string SetConfigurationsDesktopPC()
        {
            return "Setting configuration for WorkstationDesktop.";
        }
    }

    public interface IAbstractNotebookPC
    {
        string SetConfigurationsNotebookPC();
        
        
    }

    class GamingNotebook : IAbstractNotebookPC
    {
        public string SetConfigurationsNotebookPC()
        {
            return "Setting configuration for GamingDesktop.";
        }

    }

    class WorkstationNotebook : IAbstractNotebookPC
    {
        public string SetConfigurationsNotebookPC()
        {
            return "Setting configuration for WorkstationDesktop.";
        }
    }

}