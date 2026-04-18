namespace CRAms.Data.Constants
{
#pragma warning disable CA1052 // Static holder types should be Static or NotInheritable - Cannot be static for TypeGen
    public class ProductClassifications
#pragma warning restore CA1052 // Static holder types should be Static or NotInheritable
    {
        // Since TypeGen seems not to be able to generate a dictionary in TypeScript based on
        // Dictionary<Classification, IEnumerable<string>>, single IEnumerables will be used.
        public static readonly IEnumerable<string> Products = [
            "Software as a Service (SaaS) products which are purely available as a service that do not require downloading or installing and are not essential for the functioning of a connected hardware product",
            "Non-commercial Open Source Software",
        ];

        public static readonly IEnumerable<string> ProductsWithDigitalElements = [
            // Based on Article (3) 1,2 CRA
            "A software or hardware product with data processing over a network in which the absence of said data processing would prevent the product from performing one of its functions"
        ];

        public static readonly IEnumerable<string> ImportantProductWithDigitalElementsClassOne = [
            "Identity management systems and privileged access management software and hardware, including authentication and access control readers, including biometric readers",
            "Standalone and embedded browsers",
            "Password managers",
            "Software that searches for, removes, or quarantines malicious software",
            "Products with digital elements with the function of virtual private network (VPN)",
            "Network management systems",
            "Security information and event management (SIEM) systems",
            "Boot managers",
            "Public key infrastructure and digital certificate issuance software",
            "Physical and virtual network interfaces",
            "Operating systems",
            "Routers, modems intended for the connection to the internet, and switches",
            "Microprocessors with security-related functionalities",
            "Microcontrollers with security-related functionalities",
            "Application specific integrated circuits (ASIC) and field-programmable gate arrays (FPGA) with security-related functionalities",
            "Smart home general purpose virtual assistants",
            "Smart home products with security functionalities, including smart door locks, security cameras, baby monitoring systems and alarm systems",
            "Internet connected toys covered by Directive 2009/48/EC of the European Parliament and of the Council (1) that have social interactive features (e.g. speaking or filming) or that have location tracking features",
            "Personal wearable products to be worn or placed on a human body that have a health monitoring (such as tracking) purpose and to which Regulation (EU) 2017/745 or (EU) No 2017/746 do not apply, or personal wearable products that are intended for the use by and for children",
        ];

        public static readonly IEnumerable<string> ImportantProductWithDigitalElementsClassTwo = [
            "Hypervisors and container runtime systems that support virtualised execution of operating systems and similar environments",
            "Firewalls, intrusion detection and prevention systems",
            "Tamper-resistant microprocessors",
            "Tamper-resistant microcontrollers",
        ];

        public static readonly IEnumerable<string> CriticalProductsWithDigitalElements = [
            "Hardware Devices with Security Boxes",
            "Smart meter gateways within smart metering systems as defined in Article 2, point (23) of Directive (EU) 2019/944 of the European Parliament and of the Council and other devices for advanced security purposes, including for secure cryptoprocessing",
            "Smartcards or similar devices, including secure elements",
        ];
    }
}
