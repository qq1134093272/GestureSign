﻿namespace GestureSign.Common.Plugins
{
    public interface IPlugin
    {
        #region Properties

        string Name { get; }
        string Category { get; }
        string Description { get; }
        bool IsAction { get; }
        object GUI { get; }

        #endregion

        #region Methods

        void Initialize();
        bool Gestured(PointInfo ActionPoint);
        bool Deserialize(string SerializedData);
        string Serialize();

        #endregion

        #region Host Controls

        IHostControl HostControl { get; set; }

        #endregion
    }
}
