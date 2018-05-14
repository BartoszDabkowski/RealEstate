import { Component, Input, Output, EventEmitter} from '@angular/core';
import { OnChanges } from '@angular/core';

@Component({
    selector: 'pagination',
    templateUrl: './pagination.component.html'
})
export class PaginationComponent implements OnChanges {
    @Input('total-items') totalItems: any;
    @Input('page-size') pageSize = 10;
    @Output('page-changed') pageChanged = new EventEmitter();
    pages: any[];
    currentPage = 1;

    ngOnChanges() {
        this.currentPage = 1;

        var pagesCount = Math.ceil(this.totalItems / this.pageSize);
        this.pages = [];
        for (var i = 1; i <= pagesCount; i++)
            this.pages.push(i);
    }

    changePage(page: any) {
        this.currentPage = page;
        this.pageChanged.emit(page);
    }

    previous() {
        if (this.currentPage == 1)
            return;

        this.currentPage--;
        this.pageChanged.emit(this.currentPage);
    }

    next() {
        if (this.currentPage == this.pages.length)
            return;

        this.currentPage++;
        this.pageChanged.emit(this.currentPage);
    }
}