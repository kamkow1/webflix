import { User } from "../../interfaces";
import { observable, action } from 'mobx'

export default class UserStore {
    @observable user: User

    @action setUser({ user: User }): void {
        this.user = this.user;
    }
}