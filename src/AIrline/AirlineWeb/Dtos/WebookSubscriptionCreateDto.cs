namespace AirlineWeb.Dtos;

public class WebookSubscriptionCreateDto
{
    public string WebhookURI { get; set; }
    public string Secret { get; set; }
    public string WebhookType { get; set; }
    public string WebhookPublisher { get; set; }
}
