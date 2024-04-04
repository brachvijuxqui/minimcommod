try
{
    // Set a timeout period (in milliseconds).
    int timeout = 30000; // 30 seconds

    // Wait for the process to exit within the timeout period.
    bool exited = process.WaitForExit(timeout);

    if (!exited)
    {
        // If the process does not exit within the timeout, handle it accordingly.
        Console.WriteLine("The process did not exit within the timeout period.");
        // Optionally, force the process to exit.
        process.Kill();
    }
    else
    {
        // The process exited successfully within the timeout.
        Console.WriteLine("The process exited successfully.");
    }
}
catch (Exception ex)
{
    // Handle any exceptions that may have occurred during the wait.
    Console.WriteLine($"An error occurred: {ex.Message}");
}
