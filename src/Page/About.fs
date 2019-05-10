namespace Page

module About = 

  module Types = 

    type Model = int
    type Msg = | DoSomething

    let initialModel = 0
  
  module State = 

    open Types
    open Elmish
    
    let update msg model = 
      match msg with 
      | DoSomething -> model, Cmd.none

  module View = 

    open Types
    open Fulma
    open Fable.Core.JsInterop
    open Fable.React
    open Fable.React.Props
    open ReactReveal

    let pic = 
        Hero.hero [ 
          Hero.IsLarge
          Hero.Props [
            Style [
              BackgroundImage """url("./mas.jpg")"""
              BackgroundRepeat "no-repeat"
              BackgroundPosition "center center"
              BackgroundSize "cover"
              BackgroundColor "#fff"
              Height "200px"
            ]
          ]
        
        ] [ 
          div [ ClassName "picCredits"] [ str "Picture credits: PanaTomix CC-BY-NC 2.0 0b" ]          
        ]

    let cover = 
        Hero.hero [ 
          Hero.IsFullHeight
          Hero.Props [
            Style [
              BackgroundImage """url("./landing.jpg")"""
              BackgroundRepeat "no-repeat"
              BackgroundPosition "center center"
              BackgroundSize "cover"
              BackgroundColor "#fff"
            ]
          ]
        
        ] [
          div [] [
            fade [] [
              div [
                ClassName "ftitle"
              ] [
                Heading.h1 [] [
                    span [ ClassName "top" ] [ str "FABLE" ]
                    br []
                    span [ ClassName "bottom" ] [ str "CONF'19" ]
                ]
                div [
                  ClassName "dates"
                ] [
                    span [ ClassName "date"] [ str "6/7 sept 2019" ]
                    br []
                    span [ ClassName "date"] [ 
                      strong [] [str "Antwerp" ]
                      str ", Belgium" ]
                ]
                div [
                  ClassName "ticket"
                ] [
                    a [ 
                      ClassName "fbutton"
                      Href "https://www.eventbrite.com/e/fable-conference-2019-tickets-60873524350"
                      Target "_blank"
                    ] [
                      div [ClassName "innerLeft"] []
                      div [ClassName "innerRight"] [ str "BUY YOUR TICKET"]              
                    ]                      

                ]
                //hr []
                div [ 
                  ClassName "axxesLogo"
                ] [ 
                  span [] [ strong [] [ str "Powered by "]]
                  a [ Href "https://axxes.com/"; Target "_blank" ] [
                    img [
                      Src "./logo.png"
                    ] 
                  ]
                ]
              ]
            ]
          ]
        ]

    let about = 
        Hero.hero [ 
          Hero.IsLarge
          Hero.Props [
            ClassName "contents"
          ]
        
        ] [
          Hero.body [ Props [ ClassName "addMargins"] ] [
            Columns.columns [] [
              Column.column [ 
                Column.Width (Screen.All, Column.IsThreeQuarters)
              ] [
                Content.content [] [
                  p[] [strong [] [str "Come to the beautiful city of Antwerp and be part of the FABLECONF conferences! This year again FABLECONF will provide two days of F# and Javascript opportunities for learning and meeting people frome the Fable community." ]]
                  h2[ ] [str "Friday: talks"]
                  h4[ ] [str "Ankerrui 9, 2000 Antwerpen"]
                  p [][str "Day one will consists of talks. "; i[][ str "(More information to come soon...)"]]
                  h2[ ] [str "Saturday: workshops"]
                  h4[ ] [str "Entrepotkaai 10A, 2000 Antwerpen"]
                  p [][str "Day two will be filled with practical workshops and chances to sit down and works alongside members of the F# community to give confidence in writing Fable applications that take full advantage of F# and Javascript."]
                  h2[ ] [str "F# enlightenment"]
                  p[] [ str "No matter if you're new to Fable, don't have much experience in front or server development or even if you don't know F# yet. If you're a developer interested in writing code using a functional programming language designed for hogh productivity and with cutting-edge tooling, this year's FABLECONF will have something for you!"]
                ]
              ]
            ]
          ]
        ]
      
    let ticket = 
        Hero.hero [ 
          Hero.IsMedium
          Hero.Props [
            ClassName "contents"
          ]          
        ] [
          Hero.body [ Props [ ClassName "addMargins"] ] [
            Content.content [] [
              Columns.columns [ ] [
                Column.column [
                  Column.Width (Screen.All, Column.IsThreeQuarters)
                ] [
                  a [ 
                    ClassName "fbutton"
                    Href "https://www.eventbrite.com/e/fable-conference-2019-tickets-60873524350"
                    Target "_blank"
                  ] [
                    div [ClassName "innerLeft"] []
                    div [ClassName "innerRight"] [ str "JOIN US! BUY YOUR TICKET NOW!"]              
                  ]
                ]
              ]
            ]
          ]
        ]

    let cfp =  
        Hero.hero [ 
          Hero.IsMedium
          Hero.Props [
            ClassName "contents"
          ]          
        ] [
          Hero.body [ Props [ ClassName "addMargins"] ] [
            Content.content [] [
              Columns.columns [ ] [
                Column.column [
                  Column.Width (Screen.All, Column.IsThreeQuarters)
                ] [
                  Content.content [] [
                    h2[ ] [str "Call for papers"]
                    p [] [
                      str "Do you want to be part of one of the best events organized by the F# community? Have you been to the past editions in Bordeaux and Berlin and think it's time to live it from the other side? Then this is your opportunity to send a talk proposal for FableConf 2019 taking place the next September at the beautiful city of Antwerp in Belgium!"
                    ]
                    p [] [
                      str "We're looking for talks and workshops about Fable, either introductory or advanced. But we're also open to broader topics like other uses of F# for web projects, or related technologies commonly used in Fable projects, like Webpack, JS optimization, CSS styling, etc. Really excited to know about all your great ideas to help the community!"
                    ]
                  ]
                  a [ 
                    ClassName "fbutton"
                    Href "https://docs.google.com/forms/d/e/1FAIpQLSfarg6l9_SRju5ynIAA2OwrFRGuy2sUHUrd-T-P6q1SjVyDow/viewform"
                    Target "_blank"
                  ] [
                    div [ClassName "innerLeft"] []
                    div [ClassName "innerRight"] [ str "SUBMIT YOUR IDEA!"]              
                  ]
                ]
              ]
            ]
          ]
        ]

    let sponsors = 
        Hero.hero [ 
          Hero.IsLarge
          Hero.Props [
            ClassName "contents"
          ]
        
        ] [
          Hero.body [ Props [ ClassName "addMargins"] ] [
            Content.content [] [
              h2[ ] [str "Sponsors"]
            ]
            Tile.ancestor [] [
              Tile.parent [
                Tile.IsVertical
                Tile.Size Tile.Is2
                ] 
                [
                Tile.child [] [
                  zoom [] [
                    a [ Href "https://axxes.com/"; Target "_blank" ] [
                      Image.image [ Image.Is128x128 ]
                        [ img [ Src "./logo.png" ] ]
                    ]
                  ]
                ]
              ]
              Tile.parent [
                Tile.IsVertical
              ] [
                Tile.child [] [
                  zoom [] [
                    Image.image [ Image.Is96x96 ]
                      [ 
                        a [ Href "https://www.biensurgraphisme.com/about"; Target "_blank"] [
                          img [ Src "https://static.wixstatic.com/media/df463e_ae881edc7926481fb32950bbd51745a0~mv2.png/v1/crop/x_0,y_30,w_537,h_619/fill/w_201,h_230,al_c,q_80,usm_0.66_1.00_0.01/df463e_ae881edc7926481fb32950bbd51745a0~mv2.webp" ] ]
                        ]
                  ]
                ]
              ]
            ]
          ]
        ]

    let coc  = 
        Hero.hero [ 
          Hero.IsLarge
          Hero.Props [
            ClassName "contents"
          ]
        
        ] [
          Hero.body [ Props [ ClassName "addMargins"] ] [
            Content.content [] [
              h2[ ] [str "Code of Conduct"]
              h4[ ] [str "Be responsible, be open and be considerate"]
            ]
            Columns.columns [ ] [
              Column.column [
                Column.Width (Screen.All, Column.IsThreeQuarters)
              ] [
                Content.content [] [
                  p[] [
                    str "Our conference is dedicated to providing a harassment-free conference experience for everyone, regardless of gender, gender identity and expression, age, sexual orientation, disability, physical appearance, body size, race, ethnicity, religion (or lack thereof), or technology choices. We do not tolerate harassment of conference participants in any form. Sexual language and imagery is not appropriate for any conference venue, including talks, workshops, parties, Twitter and other online media. Conference participants violating these rules may be sanctioned or expelled from the conference without a refund at the discretion of the conference organisers."
                  ]
                ]
              ]
              Column.column [
                Column.Modifiers [
                  Modifier.IsHiddenOnly(Screen.Mobile, true)
                ]
              ] [
                zoom [] [
                  Image.image [ Image.Is128x128 ]
                    [ img [ Src "https://i2.wp.com/diversitycharter.org/wp-content/uploads/2016/05/sharelogo_small.png?w=200&ssl=1" ] ]
                ]
              ]
            ]
          ]
        ]

    let footer =
      let cesure = 
          Level.item [ Level.Item.Modifiers [ Modifier.IsHiddenOnly (Screen.Mobile, true)]] [ str "|"]
        
      Footer.footer[ Props [ Id "footer"] ][
        Level.level [
        ] [
          Level.item [] [ 
            span [] [ 
              str "web design by "
              a [ Href "https://biensurgraphisme.com"; Target "_blank"] [ strong [] [str " Biensür Graphisme"] ]
            ]
          ]
          cesure
          Level.item [] [
            span [] [
              str "FABLE CONF is organised by Fable lovers. Powered this year by "
              a [ Href "https://axxes.com/"; Target "_blank"] [ str " Axxes!"]
            ]
          ]
        ]
      ]

    let root model dispatch = 
      div [] [
        cover
        fade [] [about]
        fade [] [pic]
        fade [] [cfp]
        fade [] [pic]
        //fade [] [ticket]
        fade [] [sponsors]
        fade [] [coc]
        footer
      ]