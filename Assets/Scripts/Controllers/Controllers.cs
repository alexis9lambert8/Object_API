using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using ObjectsApi.Models;
using ObjectsApi.Services;
using UnityEngine;

namespace ObjectsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlarmsController : ControllerBase
    {
        private readonly AlarmService _alarmService;

        public AlarmsController(AlarmService alarmService)
        {
            _alarmService = alarmService;
        }

        // GET: APIRoute/Alarms
        [HttpGet]
        public ActionResult<List<Alarm>> Get()
        {
            return _alarmService.Get();
        }


        // GET: APIRoute/Alarms/<id>
        [HttpGet("{id:length(24)}")]
        public ActionResult<Alarm> Get(string id)
        {
            var alarm = _alarmService.Get(id);

            if (alarm == null)
            {
                return NotFound();
            }

            return alarm;
        }

        // CREATE: APIRoute/Alarms/
        [HttpPost]
        public ActionResult<Alarm> Create(Alarm alarm)
        {
            _alarmService.Create(alarm);

            return CreatedAtRoute("", new { id = alarm.Id.ToString() }, alarm);
        }

        // UPDATE: APIRoute/Alarms/<id>
        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Alarm alarmToChangeTo)
        {
            var oldAlarm = _alarmService.Get(id);

            if (oldAlarm == null)
            {
                return NotFound();
            }

            _alarmService.Update(id, alarmToChangeTo);

            return NoContent();
        }

        // DELETE: APIRoute/Alarms/<id>
        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var alarm = _alarmService.Get(id);

            if (alarm == null)
            {
                return NotFound();
            }

            _alarmService.Remove(alarm.Id);

            return NoContent();
        }
    }
}