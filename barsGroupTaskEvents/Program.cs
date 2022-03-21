using barsGroupTaskEvents;

InputStopper handler = new InputStopper();

handler.OnKeyPressed += handler.Print;
handler.Run();