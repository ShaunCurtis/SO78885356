namespace SO78885356.Components;

public class UserService
{
    public string? AvatarName { get; private set; }

    public event EventHandler<EventArgs>? AvatarChanged;

    public void ChangeAvatar(object? sender, string? name)
    {
        this.AvatarName = name;
        this.AvatarChanged?.Invoke(sender, new EventArgs());
    }
}
