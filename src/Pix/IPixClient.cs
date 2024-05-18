public interface IPixClient : IPayload
{
    /// <summary>
    /// Gets the CobPayload interface.
    /// </summary>
    ICobPayload CobPayload { get; }

    /// <summary>
    /// Gets the Cob interface.
    /// </summary>
    ICob Cob { get; }

    /// <summary>
    /// Gets the CobV interface.
    /// </summary>
    ICobV CobV { get; }

    /// <summary>
    /// Gets the LoteCobV interface.
    /// </summary>
    ILoteCobV LoteCobV { get; }

    /// <summary>
    /// Gets the PayloadLocation interface.
    /// </summary>
    IPayloadLocation PayloadLocation { get; }

    /// <summary>
    /// Gets the Pix interface.
    /// </summary>
    IPix Pix { get; }

    /// <summary>
    /// Gets the Webhook interface.
    /// </summary>
    IWebhook Webhook { get; }
}
