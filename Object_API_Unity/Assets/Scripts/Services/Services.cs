using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using ObjectsApi.Models;
using UnityEngine;

namespace ObjectsApi.Services
{
    public class AlarmService
    {
        public IMongoCollection<Alarm> _alarms;

        public AlarmService()
        {
            var client = new MongoClient(ObjectDatabaseSettings.ConnectionString);
            var database = client.GetDatabase(ObjectDatabaseSettings.DatabaseName);

            _alarms = database.GetCollection<Alarm>(ObjectDatabaseSettings.AlarmCollectionName);

            var collection = database.GetCollection<BaseObject>(ObjectDatabaseSettings.AlarmCollectionName);
        }

        public List<Alarm> Get() =>
            _alarms.Find(obj => obj.Type == "Alarm").ToList();

        public Alarm Get(string id) =>
            _alarms.Find<Alarm>(alarm => alarm.Id == id).FirstOrDefault();

        public Alarm Create(Alarm alarm)
        {
            _alarms.InsertOne(alarm);
            return alarm;
        }

        public void Update(string id, Alarm targetAlarm) =>
            _alarms.ReplaceOne(alarm => alarm.Id == id, targetAlarm);

        public void Remove(Alarm targetAlarm) =>
            _alarms.DeleteOne(alarm => alarm.Id == targetAlarm.Id);

        public void Remove(string id) =>
            _alarms.DeleteOne(alarm => alarm.Id == id);
    }
}