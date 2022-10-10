﻿using System;
using System.Windows.Input;
using DesktopApp.ui.newNoteWindows;

namespace DesktopApp.notes.commands;

public class AddNoteCommand : ICommand
{
    private readonly Category<Note> _category;
    private readonly NoteType _noteType;

    public AddNoteCommand(Category<Note> category, NoteType noteType)
    {
        _category = category;
        _noteType = noteType;
    }

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        switch (_noteType)
        {
            case NoteType.Contact:
                var newContactNoteWindow = new NewContactNoteWindow(_category, _noteType);
                newContactNoteWindow.Show();
                break;
            case NoteType.Plaintext:
                break;
        }
    }

    public event EventHandler CanExecuteChanged;
}