
# Cursor Paging Object

## Structure

`CursorPagingObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Href` | `string` | Optional | A link to the Web API endpoint returning the full result of the request. |
| `Limit` | `int?` | Optional | The maximum number of items in the response (as set in the query or by default). |
| `Next` | `string` | Optional | URL to the next page of items. ( `null` if none) |
| `Cursors` | [`CursorObject`](../../doc/models/cursor-object.md) | Optional | The cursors used to find the next set of items. |
| `Total` | `int?` | Optional | The total number of items available to return. |

## Example (as JSON)

```json
{
  "href": "href4",
  "limit": 200,
  "next": "next0",
  "cursors": {
    "after": "after8",
    "before": "before6"
  },
  "total": 38
}
```
