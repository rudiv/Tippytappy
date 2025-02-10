namespace Tippytappy.Test;

public class DocumentTests
{
    [Fact]
    public void ComplexDocument()
    {
      var json = """
                 {
                   "type": "doc",
                   "content": [
                     {
                       "type": "paragraph",
                       "content": [
                         {
                           "type": "text",
                           "marks": [
                             {
                               "type": "italic"
                             }
                           ],
                           "text": "Wow"
                         },
                         {
                           "type": "text",
                           "text": ", this "
                         },
                         {
                           "type": "hardBreak"
                         },
                         {
                           "type": "text",
                           "marks": [
                             {
                               "type": "bold"
                             }
                           ],
                           "text": "editor"
                         },
                         {
                           "type": "text",
                           "text": " instance"
                         }
                       ]
                     },
                     {
                     "type": "horizontalRule"
                     },
                     {
                       "type": "bulletList",
                       "content": [
                         {
                           "type": "listItem",
                           "content": [
                             {
                               "type": "paragraph",
                               "content": [
                                 {
                                   "type": "text",
                                   "text": "Has lists"
                                 }
                               ]
                             }
                           ]
                         },
                         {
                           "type": "listItem",
                           "content": [
                             {
                               "type": "paragraph",
                               "content": [
                                 {
                                   "type": "text",
                                   "marks": [
                                     {
                                       "type": "bold"
                                     }
                                   ],
                                   "text": "A"
                                 },
                                 {
                                   "type": "text",
                                   "text": " "
                                 },
                                 {
                                   "type": "text",
                                   "marks": [
                                     {
                                       "type": "italic"
                                     }
                                   ],
                                   "text": "second"
                                 },
                                 {
                                   "type": "text",
                                   "marks": [
                                     {
                                       "type": "bold"
                                     },
                                     {
                                       "type": "italic"
                                     }
                                   ],
                                   "text": "!"
                                 }
                               ]
                             }
                           ]
                         }
                       ]
                     },
                     {
                       "type": "orderedList",
                       "attrs": {
                         "start": 1
                       },
                       "content": [
                         {
                           "type": "listItem",
                           "content": [
                             {
                               "type": "paragraph",
                               "content": [
                                 {
                                   "type": "text",
                                   "text": "And "
                                 },
                                 {
                                   "type": "text",
                                   "marks": [
                                     {
                                       "type": "bold"
                                     }
                                   ],
                                   "text": "numbered"
                                 },
                                 {
                                   "type": "text",
                                   "text": " lists"
                                 }
                               ]
                             }
                           ]
                         },
                         {
                           "type": "listItem",
                           "content": [
                             {
                               "type": "paragraph",
                               "content": [
                                 {
                                   "type": "text",
                                   "text": "Number "
                                 },
                                 {
                                   "type": "text",
                                   "marks": [
                                     {
                                       "type": "bold"
                                     },
                                     {
                                       "type": "italic"
                                     }
                                   ],
                                   "text": "2"
                                 },
                                 {
                                   "type": "text",
                                   "text": "!"
                                 }
                               ]
                             }
                           ]
                         }
                       ]
                     },
                     {
                       "type": "codeBlock",
                       "attrs": {
                         "language": null
                       },
                       "content": [
                         {
                           "type": "text",
                           "text": "and code"
                         }
                       ]
                     },
                     {
                       "type": "blockquote",
                       "content": [
                         {
                           "type": "paragraph",
                           "content": [
                             {
                               "type": "text",
                               "text": "and quotes"
                             }
                           ]
                         }
                       ]
                     },
                     {
                       "type": "paragraph"
                     }
                   ]
                 }
                 """;
      var config = new TippytappyConfiguration()
        .AddStarterKit();
      var tiptap = new Tippytappy(config);
      var result = tiptap.Render(json);
      Assert.Equal("""
                   <p><em>Wow</em>, this <br/>
                   <strong>editor</strong> instance</p>
                   <hr/>
                   <ul>
                   <li>
                   Has lists</li>
                   <li>
                   <strong>A</strong> <em>second</em><strong><em>!</em></strong></li>
                   </ul>
                   <ol start="1">
                   <li>
                   And <strong>numbered</strong> lists</li>
                   <li>
                   Number <strong><em>2</em></strong>!</li>
                   </ol>
                   <pre><code>and code</code></pre>
                   <blockquote><p>and quotes</p>
                   </blockquote><p></p>
                   
                   """, result);
    }
}