# LifeSure MVC Project

A comprehensive insurance company website built with ASP.NET MVC 5, featuring AI-powered content generation and social media integration.

## 🚀 Project Overview

LifeSure is a modern insurance company website that provides a complete content management system with AI integration for automatic content generation. The project includes both public-facing pages and an admin panel for content management.

## 🛠️ Technology Stack

- **Framework**: ASP.NET MVC 5
- **.NET Version**: 4.7.2
- **Database**: SQL Server with Entity Framework 6
- **Frontend**: HTML5, CSS3, JavaScript, Bootstrap 5
- **AI Integration**: 
  - ChatGPT API (RapidAPI) for FAQ generation
  - Hugging Face API for image generation
- **Social Media APIs**: 
  - Twitter API (RapidAPI)
  - LinkedIn API (RapidAPI)
- **Additional Libraries**: 
  - Newtonsoft.Json
  - jQuery
  - Font Awesome
  - Bootstrap Icons

## 📁 Project Structure

```
LifeSure_Mvc_Project/
├── LifeSure.WebApp/                 # Main web application
│   ├── Controllers/                 # MVC Controllers
│   │   ├── AdminController.cs      # Admin panel functionality
│   │   ├── HomeController.cs       # Public pages
│   │   └── LanguageController.cs   # Multi-language support
│   ├── Models/                     # Data models and view models
│   │   ├── DataModels/            # Entity Framework models
│   │   ├── CombinedUserViewModel.cs
│   │   ├── LinkedInUserViewModel.cs
│   │   └── TwitterUserViewModel.cs
│   ├── Services/                   # External API services
│   │   ├── LinkedInService.cs     # LinkedIn API integration
│   │   └── TwitterService.cs      # Twitter API integration
│   ├── Views/                      # Razor views
│   │   ├── Admin/                 # Admin panel views
│   │   ├── Home/                  # Public page views
│   │   └── Shared/                # Layout and shared views
│   ├── App_Data/                  # Application data
│   ├── App_GlobalResources/       # Localization resources
│   ├── Content/                   # CSS and static assets
│   ├── Scripts/                   # JavaScript files
│   └── LifeSure-1.0.0/           # Template assets
├── packages/                      # NuGet packages
└── LifeSure_Mvc_Project.sln      # Solution file
```

## 🎯 Key Features

### 🌐 Public Website
- **Multi-language Support**: English and Turkish
- **Responsive Design**: Mobile-friendly Bootstrap layout
- **Social Media Integration**: Real-time Twitter and LinkedIn follower counts
- **Dynamic Content**: All content managed through admin panel

### 🔧 Admin Panel
- **Complete CMS**: Manage all website content
- **AI-Powered Content Generation**:
  - ChatGPT integration for FAQ generation
  - Hugging Face integration for image generation
- **Social Media Management**: Twitter and LinkedIn integration
- **Multi-language Content Management**

### 🤖 AI Integrations

#### ChatGPT FAQ Generation
- **Endpoint**: `/Admin/GenerateChatGPTFAQs`
- **Features**:
  - Generate 3 FAQs from a single prompt
  - Automatic formatting and parsing
  - Bulk save functionality
  - Error handling with fallback content

#### Hugging Face Image Generation
- **Endpoint**: `/Admin/GenerateImage`
- **Features**:
  - Generate images from text descriptions
  - Automatic image preview
  - Base64 encoding for immediate display
  - Integration with service management

### 📱 Social Media Integration

#### Twitter Integration
- **Service**: `TwitterService.cs`
- **Features**:
  - Real-time follower count display
  - Username validation
  - Error handling with fallback values
- **API**: RapidAPI Twitter service

#### LinkedIn Integration
- **Service**: `LinkedInService.cs`
- **Features**:
  - Real-time follower count display
  - Profile identifier extraction
  - Direct profile linking
- **API**: RapidAPI LinkedIn scraper

## 🗄️ Database Schema

### Core Tables
- `Tbl_About` - Company information
- `Tbl_Contact` - Contact details
- `Tbl_Employee` - Team members
- `Tbl_FAQ` - Frequently asked questions
- `Tbl_Feature` - Company features
- `Tbl_Offer` - Service offers
- `Tbl_Service` - Services offered
- `Tbl_Testimonial` - Customer testimonials

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2019 or later
- SQL Server (LocalDB or full instance)
- .NET Framework 4.7.2

### Installation
1. Clone the repository
2. Open `LifeSure_Mvc_Project.sln` in Visual Studio
3. Update connection string in `Web.config` if needed
4. Restore NuGet packages
5. Build and run the project

### Configuration
- Update API keys in the following files:
  - `AdminController.cs`:
    - `YOUR-HUGGING-FACE-API-KEY` for image generation
    - `YOUR-RAPIDAPI-KEY` for ChatGPT FAQ generation
  - `TwitterService.cs`:
    - `YOUR-RAPIDAPI-KEY` for Twitter integration
  - `LinkedInService.cs`:
    - `YOUR-RAPIDAPI-KEY` for LinkedIn integration

## 📸 Screenshots

[Add your screenshots here]

### Public Website
- Home page with dynamic content
- About page with company information
- Services page with AI-generated images
- FAQ page with AI-generated content
- Contact page with real-time social media stats

### Admin Panel
- Dashboard overview
- FAQ management with AI generation
- Service management with image generation
- Social media integration
- Multi-language content management

## 🔧 API Endpoints

### Admin Endpoints
- `GET /Admin/Dashboard` - Admin dashboard
- `GET /Admin/Faq` - FAQ management
- `POST /Admin/GenerateChatGPTFAQs` - AI FAQ generation
- `POST /Admin/GenerateImage` - AI image generation
- `GET /Admin/Service` - Service management
- `GET /Admin/About` - About content management
- `GET /Admin/Contact` - Contact management
- `GET /Admin/Employee` - Team management
- `GET /Admin/Testimonial` - Testimonial management

### Public Endpoints
- `GET /` - Home page
- `GET /Home/About` - About page
- `GET /Home/Service` - Services page
- `GET /Home/FAQ` - FAQ page
- `GET /Home/Contact` - Contact page

## 🌍 Localization

The project supports multiple languages through resource files:
- `App_GlobalResources/SharedResource.resx` (English)
- `App_GlobalResources/SharedResource.tr.resx` (Turkish)

Language switching is handled by `LanguageController.cs`.

## 🔒 Security Features

- Admin panel authentication
- API key management
- Input validation and sanitization
- Error handling with fallback mechanisms
- Secure database connections

## 📊 Performance Optimizations

- Entity Framework optimization
- Static asset bundling
- Image optimization
- Caching strategies
- Async/await patterns for API calls

## 🐛 Error Handling

- Comprehensive try-catch blocks
- API error fallbacks
- User-friendly error messages
- Debug logging for development
- Graceful degradation for external services

## 🔄 Future Enhancements

- Additional AI integrations
- Enhanced social media features
- Advanced analytics
- Mobile app development
- Additional language support

## 📝 License

This project is proprietary software developed for LifeSure Insurance Company.

## 👥 Contributing

This is a private project. For questions or support, please contact the development team.

## 📞 Support

For technical support or questions about the project, please refer to the development documentation or contact the project maintainers.

---

**Last Updated**: December 2024
**Version**: 1.0.0
**Framework**: ASP.NET MVC 5
**Database**: SQL Server with Entity Framework 6 