package main

import (
    "fmt"
    "log"
    "net/http"
)

func homeHandler(w http.ResponseWriter, r *http.Request) {
    fmt.Fprintf(w, "Hello, Editor")
}

func fileOpenHandler(w http.ResponseWriter, r *http.Request) {
    http.ServeFile(w, r, "open.html")
}

func fileEditHandler(w http.ResponseWriter, r *http.Request) {
    http.ServeFile(w, r, "edit.html")
}

func main() {
    // decare routes
    http.HandleFunc("/", homeHandler)
    http.HandleFunc("/file/open", fileOpenHandler)
    http.HandleFunc("/file/edit", fileEditHandler)

    // run server
    fmt.Println("Server listening at localost:3000")
    log.Fatal(http.ListenAndServe(":3000", nil))
}
