using cakeslice;
using MongoDB.Driver;
using ObjectsApi.Models;
using ObjectsApi.Services;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnityController : MonoBehaviour
{
    public AlarmService alarmService;
    private void Awake()
    {
        alarmService = new AlarmService();
    }

}
