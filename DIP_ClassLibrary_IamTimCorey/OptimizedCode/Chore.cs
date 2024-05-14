﻿namespace DIP_ClassLibrary_IamTimCorey.OptimizedCode;

public class Chore : IChore
{
    private ILogger _logger;
    private IMessageSender _messageSender;
    public string? ChoreName { get; set; }
    public IPerson? Owner { get; set; }

    public double HoursWorked { get; set; }
    public bool IsComplete { get; set; }

    public Chore(ILogger logger, IMessageSender messageSender)
    {
        _logger = logger;
        _messageSender = messageSender;
    }

    public void PerformedWork(double hours)
    {
        HoursWorked += hours;
        _logger.Log($"Completed {ChoreName}");
    }

    public void CompleteChore()
    {
        IsComplete = true;
        _logger.Log($"Completed {ChoreName}");

        _messageSender.SendMessage(Owner!, $"The chore {ChoreName} is completed.");

    }
}

