if (entities.Count > 0 && GetAsyncKeyState(AIMKEY) < 0 && renderer.aimbot)
{
    if (entities[0].pixelDistance < renderer.FOVCircle)
    {
        // Calculate the 2D screen position of the head
        Vector2 head2D = entities[0].head2d;

        // Get current mouse position
        System.Drawing.Point currentMousePos;
        GetCursorPos(out currentMousePos);

        // Calculate the movement delta to the target head position
        int deltaX = (int)(head2D.X - currentMousePos.X);
        int deltaY = (int)(head2D.Y - currentMousePos.Y);

        if (entities[0].spotted && renderer.vischeckAimbot)
        {
            mouse_event(MOUSEEVENTF_MOVE, (uint)(deltaX), (uint)(deltaY), 0, 0);
        } else if (!renderer.vischeckAimbot)
        {
            
            mouse_event(MOUSEEVENTF_MOVE, (uint)(deltaX), (uint)(deltaY), 0, 0);
        }
    }
}
