using System;
using System.Collections.Generic;

namespace ObjectsApi.Models
{
    public class BaseObject
    {
        public string Name;
        public string Type;
        public string Id;
        public List<string> ConnectedEquipment;
        public bool Active;
        public Guid AlarmId;
        public Alarm Alarm;
    }

    public class Conveyer: BaseObject
    {
        public Conveyer(string name, string id, List<string> connectedEquipment, bool active, Guid alarmId, Alarm alarm)
        {
            Name = name;
            Type = "Conveyer";
            Id = id;
            ConnectedEquipment = connectedEquipment;
            Active = active;
            AlarmId = alarmId;
            Alarm = alarm;
        }
    }

    public class Tug : BaseObject
    {
        public Tug(string name, string id, List<string> connectedEquipment, bool active, Guid alarmId, Alarm alarm)
        {
            Name = name;
            Type = "Tug";
            Id = id;
            ConnectedEquipment = connectedEquipment;
            Active = active;
            AlarmId = alarmId;
            Alarm = alarm;
        }
    }

    public class Tank : BaseObject
    {
        public Tank(string name, string id, List<string> connectedEquipment, bool active, Guid alarmId, Alarm alarm)
        {
            Name = name;
            Type = "Tank";
            Id = id;
            ConnectedEquipment = connectedEquipment;
            Active = active;
            AlarmId = alarmId;
            Alarm = alarm;
        }
    }

    public class Door : BaseObject
    {
        public Door(string name, string id, List<string> connectedEquipment, bool active, Guid alarmId, Alarm alarm)
        {
            Name = name;
            Type = "Door";
            Id = id;
            ConnectedEquipment = connectedEquipment;
            Active = active;
            AlarmId = alarmId;
            Alarm = alarm;
        }
    }

    public class Alarm : BaseObject
    {
        public List<string> AffectedEquipment;
        public int AlarmType;
        public DateTime TimeOfFailure;


        public enum AlarmTypes
        {
            Generic = 1
        }
        public Alarm(string name, string id, List<string> affectedEquipment, bool active, int alarmType, DateTime timeOfFailure)
        {
            Name = name;
            Type = "Alarm";
            Id = id;
            AffectedEquipment = affectedEquipment;
            Active = active;
            AlarmType = alarmType;
            TimeOfFailure = timeOfFailure;
        }
        public Alarm()
        {
        }
    }

    public static class ObjectDatabaseSettings
    {
        public static string AlarmCollectionName { get; set; } = "Object_API";
        public static string ConnectionString { get; set; } = "mongodb+srv://defaultUser:9pickles8@cluster0.kgp0x.mongodb.net/Object_API?w=majority";
        public static string DatabaseName { get; set; } = "Object_API";
    }

}